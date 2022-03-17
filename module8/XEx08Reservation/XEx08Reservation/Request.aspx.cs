using System;
using System.Web;
using System.Web.UI;

namespace XEx08Reservation
{
    public partial class Request : Page
    {
        private readonly string _currentDate = DateTime.Today.ToShortDateString();
        private readonly string _currentYear = DateTime.Today.Year.ToString();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // set copyright year no matter what
                lblYear.Text = _currentYear;

                // display saved reservation data if there is any
                if (Session[nameof(Reservation)] != null)
                {
                    DisplayReservation();
                }
                else
                {
                    // otherwise, set default values
                    txtArrivalDate.Text = _currentDate;
                    rdoKing.Checked = true;
                }
            }
        }

        private void DisplayReservation()
        {
            var reservation = (Reservation)Session[nameof(Reservation)];

            txtArrivalDate.Text = reservation.ArrivalDate.ToShortDateString();
            txtDepartureDate.Text = reservation.DepartureDate.ToShortDateString();
            ddlNoOfPeople.SelectedValue = reservation.NoOfPeople.ToString();

            if (reservation.BedType == "King")
                rdoKing.Checked = true;
            else if (reservation.BedType == "Two Queens")
                rdoDouble.Checked = true;
            else
                rdoSingle.Checked = true;

            txtSpecialRequests.Text = reservation.SpecialRequests;
            txtFirstName.Text = reservation.FirstName;
            txtLastName.Text = reservation.LastName;
            txtEmail.Text = reservation.Email;
            txtPhone.Text = reservation.Phone;
            ddlPreferredMethod.SelectedValue = reservation.PreferredMethod;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtArrivalDate.Text = _currentDate;
            txtDepartureDate.Text = "";
            ddlNoOfPeople.SelectedIndex = -1;
            rdoKing.Checked = true;
            rdoDouble.Checked = false;
            rdoSingle.Checked = false;
            txtSpecialRequests.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            ddlPreferredMethod.SelectedIndex = 0;
            lblMessage.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var reservation = new Reservation
            {
                ArrivalDate = DateTime.Parse(txtArrivalDate.Text),
                DepartureDate = DateTime.Parse(txtDepartureDate.Text),
                NoOfPeople = int.Parse(ddlNoOfPeople.SelectedValue),
                PreferredMethod = ddlPreferredMethod.SelectedValue,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                SpecialRequests = txtSpecialRequests.Text,
            };

            if (rdoDouble.Checked)
            {
                reservation.BedType = "Two Queens";
            }
            else if (rdoKing.Checked)
            {
                reservation.BedType = "King";
            }
            else
            {
                reservation.BedType = "Single";
            }

            reservation.NoOfDays = (reservation.DepartureDate - reservation.ArrivalDate).Days;

            SaveToSession(nameof(Reservation), reservation);

            Response.Redirect("Confirm.aspx", false);
        }

        private void SaveToSession<T>(string key, T reservation) where T : class
        {
            Session[key] = reservation;
        }
    }
}
