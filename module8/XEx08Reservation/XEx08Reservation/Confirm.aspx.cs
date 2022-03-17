using System;
using System.Web;
using System.Web.UI;

namespace XEx08Reservation
{
    public partial class Confirm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblYear.Text = DateTime.Today.Year.ToString();
            DisplayReservation();
        }

        protected void btnConfirm_onClick(object sender, EventArgs e)
        {
            lblMessage.Text = "Thank you for your request. <br/> We will get back to you within 24 hours.";
        }

        private void DisplayReservation()
        {
            var sessionData = RetrieveFromSession<Reservation>();

            lblArrivalDate.Text = sessionData.ArrivalDate.ToShortDateString();
            lblBedType.Text = sessionData.BedType.ToString();
            lblDepartureDate.Text = sessionData.DepartureDate.ToShortDateString();
            lblEmail.Text = sessionData.Email.ToString();
            lblFirstName.Text = sessionData.FirstName.ToString();
            lblLastName.Text = sessionData.LastName.ToString();
            lblSpecialRequests.Text = sessionData.SpecialRequests.ToString();
            lblPreferredMethod.Text = sessionData.PreferredMethod.ToString();
            lblPhone.Text = sessionData.Phone.ToString();
            lblNoOfPeople.Text = sessionData.NoOfPeople.ToString();
            lblNoOfDays.Text = sessionData.NoOfDays.ToString();
        }

        private T RetrieveFromSession<T>()
        {
            return (T)Session[typeof(T).Name];
        }
    }
}
