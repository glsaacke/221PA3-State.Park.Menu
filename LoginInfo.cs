namespace mis221_pa3_glsaacke
{
    public class LoginInfo
    {
        private string firstName;
        private string lastName;
        private int hours;

        public LoginInfo(string firstName, string lastName, int hours){

            this.firstName = firstName;
            this.lastName = lastName;
            this.hours = hours;
        }

        public string GetFirstName(){
            return firstName;
        }

        public void SetFirstName(string firstName){
            this.firstName = firstName;
        }
    }
}