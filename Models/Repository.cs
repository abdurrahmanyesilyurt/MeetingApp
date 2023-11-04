namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users=new(); 

        public static List<UserInfo> Users {
            get{
                return  _users;
            }

        }

        static Repository(){
            _users.Add(new UserInfo(){Id=1,Name="Ali",Email="abc1@gmail.com",Phone="1111",WillAttend=true} );
            _users.Add(new UserInfo(){Id=2,Name="Veli",Email="abc2@gmail.com",Phone="2222",WillAttend=false} );
            _users.Add(new UserInfo(){Id=3,Name="Deli",Email="abc3@gmail.com",Phone="3333",WillAttend=true} );
        }
        public static void CrateUser(UserInfo user){
             user.Id=Users.Count +1 ;
            _users.Add(user);
        }

        public static UserInfo ?GetById(int id){
            return _users.FirstOrDefault(user =>user.Id==id);
        }
    }
}