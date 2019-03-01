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
        private string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        private string currentYear = DateTime.Today.Year.ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            rdoBedSize.SelectedIndex = 0;
            txtArrivalDate.Text = currentDate;
            System.Diagnostics.Debug.WriteLine(currentDate);
            lblYear.Text = currentYear;

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Thank you for your request. We will get back to you in 24 hours.";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            // Reset to defaults
            Page_Load(sender, e);

            txtDepartureData.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSpecialRequests.Text = "";
            txtTelephoneNumber.Text = "";
            ddlNumPeople.SelectedIndex = 0;

        }
    }
}