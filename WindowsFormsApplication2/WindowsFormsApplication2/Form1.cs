using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string op1, op2, op3, op4;


            
            if (apt1.Checked == true)
            {
                op1= "ผู้บริหารสถานศึกษา" ;
            }
            else  if (apt2.Checked == true)
            {
               op1= "ครูการเงินโรงเรียน" ;

            }
            else   if (radioButton2.Checked == true)
            {
                op1="เลขา" ;
            }
            else 
            {
                op1= "พนักงานทั่วไป" ;
            }
            
//str = str + "2.ระดับการศึกษา ===";
            if (bpt1.Checked == true)
            {
                op2= "ต่ำกว่าปริญญาตรี"  ;
            }
            else   if (bpt2.Checked == true)
            {
                op2= "ปริญญาตรี"  ;
            }
            else 
            {
                op2= "สูงกว่าปริญญาตรี"  ;

            }
           // str = str + "3.ประสบการณ์การทำงาน ===";
            if (cpt1.Checked == true)
            {
                op3= "น้อยกว่า 10 ปี"  ;
            }
            else  if (cpt2.Checked == true)
            {
                op3= "10-20 ปี"  ;
            }
            else 
            {
                op3= "มากกว่า 20 ปี"  ;

            }
          //  str = str + "4.ปฏิบัติหน้าที่ขนาดบริษัท ===";
            if (dpt1.Checked == true)
            {
                op4= "มีจำนวนพนักงานน้อยกว่า 120 คน"  ;
            }
            else  if (dpt2.Checked == true)
            {
                op4= "มีจำนวนพนักงาน 120-300 คน"  ;
            }
            else 
            {
                op4= "ขนาดใหญ่ มีจำนวนพนักงานมากกว่า 300 คน"  ;

                Form2  frm = new Form2   (op1,op2,op3,op4 );
                frm.Show();



            }
            
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

