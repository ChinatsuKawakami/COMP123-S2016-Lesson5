using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
     * This class defines a generic Person
     * @class Person
     * @field _name {string}
     * @field {int} _age
     */
    public class Person
    {
        //private instance VARIABLES(_)++++++++++++++++++++++++++++++++++++++++++
        private string _name;
        private int _age;
        //PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * This is a property for our _name field
         * 
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                //get data from privete and expose it to outside of class
                return this._name;
            }


            set
            {
                // Console.WriteLine("_name value set");
                this._name = value;
            }

        }
        /**
         * <summary>
         * This is public property for our _age field 
         * </summary>
         * 
         * @property {int} Age 
         */
        public int Age  //{ get; set; } //short cut write property
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }

        //CONSTRUCTOER+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is default empty constructor for the Person Class
         * 
         * @constructor Person
         * </summary>
         */
        /* public Person()
         {
             this.Name = "Unknown Name";
             this._age = 0;
            // this._name = "Unknown Name";
         }
         */

        /**
         * <summary>
       * This is  constructor that takes name as a parameter and passes 
         *it to the_name private instance variables
          </summary>
        
       * @constructor Person
       * @param {string} name
       */
        public Person(string name)
        {
            this.Name = name;
            this.Age = 0;
            this.initialize();
            //this._saysHello();
        }

        /**
         * 
         * This is the constructor that takes age as a paraneter abd oaasses
         * it to tat_age private instance variable
         * 
         * @constructor Person
         * @param {int} age
         */

        public Person()
        {
            this.initialize();
        }
        public Person(int age)
        {//public property
            this.Name = "Unknown Name";
            this.Age = age;
            this.initialize();
        }
        /**
         * This is a costructor that takes both name an age as parametar
         * it assigns the local name value to the NAme property
         * it assigns the locak age valu eo the age property
         * 
         * 
         * 
         */
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        //******************************************************************

        /**
         * <summary>
         * 
         * 
         * </summary>
         * @private 
         * @method _initialize
         * @return {void}
         */

        private void initialize()
        {
            this.Name = "unknown";
            this.Age = 0;

        }


        /**
         *  <summary>
         * This method outputs the _name value with " says hello!" to the console
         *  </summary>
         *  @method Sayshello
         *  retyrb {void}
         **/




        public void SaysHello()
        {
            Console.WriteLine(this.Name + "says hello!");
        }
        /**
         * 
         * <summary>
         * This method outputs the _name value and _age value in tge following
         * firnat : name +"is" + _age + "years old".
         *  </summary>
         *  @method ShowAge
         *  @returns {void}
         */

        public void ShowAge()
        {
            Console.WriteLine(this.Name + "is" + this.Age + "years old");
        }

    }
}
