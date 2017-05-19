using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonSnappableTypes;


namespace CSharpShapIn
{
    [CompanyInfoAttribyte(CompanyName ="My Company",CompanyUrl ="www.MyCompany.com")]
    public class CSharpModule: IAppFunctionality
    {
        void IAppFunctionality.DoIt()
        {
            MessageBox.Show("Youhave just used C#  snap-in!");
        }   
    }
}
