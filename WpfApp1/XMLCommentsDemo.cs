using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.SandcastleDemo
{

    /// Recommendations
    /// https://docs.microsoft.com/en-us/dotnet/csharp/codedoc
    /// 

        
    /// <summary>
    /// This class shows some of the functionalities of XML Comments and SandCastle.
    /// <para>If needed, the 'para' XML Tag can be used to create multiple paragraphs.</para>
    /// <para>The next paragraph will be separated from the first one.</para>
    /// Below are some of the functionalities shown:
    /// <list type="bullet">
    /// <item>Summary</item>
    /// <item>See</item>
    /// <item>SeeAlso</item>
    /// <item>Exception</item>
    /// <item>Paramref</item>
    /// <item>LineBreak (BR)</item>
    /// </list>
    /// </summary>
    /// <seealso cref="CommentDemoB"/>
    public class CommentDemoA
    {

        /// <summary>
        /// Prints the current time in the Console. 
        /// </summary>
        /// <param name="TimeToPrint">
        /// The time to print.
        /// </param>
        /// <exception cref="ArgumentNullException ">
        /// Thrown when the <paramref name="TimeToPrint"/> parameter is <c>null</c>.
        /// </exception>
        public void PrintTheTime(DateTime TimeToPrint)
        {
            //Check for null
            if (TimeToPrint == null)
                throw new ArgumentNullException(nameof(TimeToPrint));

            //Print the time
            Console.WriteLine(TimeToPrint);
        }

        /// <summary>
        /// Makes the sum of provided number A and B
        /// </summary>
        /// <param name="A">First number</param>
        /// <param name="B">Second number</param>
        /// <returns>Sum of A and B</returns>
        public int AddTwoNumbers(int A, int B)
        {
            return A + B;
        }


        /// <summary>
        /// This method is for showing the br XML Tag. <br/>
        /// By placing the tag <br/> the comment continues <br/> on the next line.
        /// </summary>
        public void DoAbsolutelyNothing()
        {

        }

     

        /// <summary>
        /// Returns the company name
        /// </summary>
        public static string CompanyName
        {
            get => "Vistalink";
        }
    }




    /// <summary>
    /// This class represents a person
    /// </summary>
    public abstract class PersonBaseClass
    {
        /// <summary>
        /// Used to store the age.
        /// </summary>
        protected int age;

        /// <summary>
        /// First Name
        /// </summary>
        public abstract string FirstName { get; }

        /// <summary>
        /// Last Name
        /// </summary>
        public abstract string LastName { get; }

        /// <summary>
        /// How old is this person now
        /// </summary>
        public int Age => age;

        /// <summary>
        /// Turns the person one year older
        /// </summary>
        public abstract void TurnOneYearOlder();

    }


 
   /// <summary>
   /// This is jos
   /// </summary>
   /// <inheritdoc/>
    public class JosVermeulen : PersonBaseClass
    {

        public JosVermeulen()
        {
            age = 0;
        }

        public override string FirstName => "Jos";

        public override string LastName => "Vermeulen";

      

        public override void TurnOneYearOlder()
        {
            age = age + 1;            
        }       
    }

    /// <summary>
    /// This is Jan
    /// </summary>
    /// <inheritdoc/>
    public class JanJanssen : PersonBaseClass
    {

        /// <inheritdoc/>
        public override string FirstName => "Jan";

        /// <inheritdoc/>
        public override string LastName => "Janssen";


        /// <inheritdoc/>
        public override void TurnOneYearOlder()
        {
            age += 1;
        }
    }
}
