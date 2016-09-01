using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SampleDataContext DataContext = new SampleDataContext();

        GridView1.DataSource = from employee in DataContext.employees
                               //where employee.Gender == "Male"
                               //where employee.Gender1 == "Male"
                               select employee;
        GridView1.DataBind();



        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //GridView2.DataSource = from EvenNum in numbers
        //                       where (EvenNum % 2) == 0
        //                       select EvenNum;
        //GridView2.DataBind();
    }
}