using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class UserGrade
    {
        private string u_g_id;                //用户成绩编号
        private string grade;                //成绩

        public string U_G_Id
        {
            get { return this.u_g_id; }
            set { this.u_g_id = value; }
        }
        public string Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
    }
}
