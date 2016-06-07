using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    
    /**
     * <summary>
     * This is the Student class it is deriverd from Person class
     * </summary>
     * @class Student
     * @extends Person
     */
    
    class Student : Person
    {

        
        //PRIVATE INSTANCE VARIABLES************************
        private string _studentID;
        private List<Course> _course = new List<Course>();

        //PUUBLIC PROPERTIES********************************
        /**
         * <summary>
         * This property ,StudentID includes a getter and setter
         * for the private instace variable _studentID
         * </summary>
         * @propety StudentID
         * 
         */
        public string StudentID
        {
            get
            {
                return _studentID;
            }
            set
            {
                this._studentID = value;
            }
        }//close public StudentID
        
        public List<Course> Course
        {
            get
            {
                return this._course;
            }
            set
            {
                this._course = value;
            }
        }
        //CONSTRUCTORS ******************************************
      
        /**
     *<summary>
     *This is the empty default Constructor for the 
     *Student class
     * </summary>
     * @constructor Student
     * @extends Person
     * @params{string}name
      *@params {int}age
      *@params {string} studentID
     */
        public Student(string name, int age,string studentID)
            :base(name,age)
        {

            this.StudentID = studentID;

        }

        //PUBLIC METHODs*************************
        /**
         *<summary>
         * This method enables the studies behavour for the student
         * </summary>
          * @method Studies
         * @return {void}
         */
        public void Studies()
        {
            Console.WriteLine(this.Name + " studies. ");
        }

        public void ShowCoyrses()
        {

        }
    }
}
