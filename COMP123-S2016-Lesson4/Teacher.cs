using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
     * <summary>
     * The teacher class is derived from the Person class
     * </summary>
     * @class Teacher
     * @extends Person
     */
    class Teacher:Person
    {
        //PRIVATE INSTANCE VARIABLES *****************
        private string _employeeID;

        //PUBLIC PROPERTIES **************************
        public string EmployeeID
    {
        get{
        return this._employeeID;
            }
        set{
          this._employeeID= value;
            }
    }
        //CONSTRUNCTOR**************
        /**
         * <summary>
         * This constructor method takes three parameters : name, age, employeeID
         * </summary>
         * @constructor Teacher
         * @param {string} name
         * @param{int} age
         * @param{string} employeeID
         */
        public Teacher(string name,int age, string employeeID)
            :base(name, age)
        {
            this._employeeID=employeeID;
        }
        //PUBLICMETHOD*******************
        /**
         * <summary>
         * This method enables the Teachers behaviour for the Teacher class
         * </summary>
         * @method Teaches
         * @return {void}
         */
        public void Teaches()
        {
            Console.WriteLine(this.Name+" teaches. ");
        }
    }
    }

