using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx06Reservation
{
    public partial class Request : System.Web.UI.Page
    {
        private DateTime currentDate = DateTime.Today;
        private string currentYear = DateTime.Today.Year.ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblYear.Text = currentYear;
            ResetAtributes();
        }

        protected void dropDownContactMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void peopleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Thank you for your request. We will get back to you within 24 hours.";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ResetAtributes();
        }

        private void ResetAtributes()
        {
            txtArrivalDate.Text = currentDate.ToString("yyyy-MM-dd");
            txtDepartureDate.Text = string.Empty;
            bedTypeRadioList.SelectedIndex = 0;
            peopleDropdown.SelectedIndex = 0;
            txtboxSpecialRequests.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmailAddress.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            dropDownContactMethod.SelectedIndex = 0;
            lblMessage.Text = string.Empty;
        }
    }
}
