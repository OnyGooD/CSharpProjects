namespace dogagyak
{

    class Member
    {
        public string name;
        public string schoolClass;

        public Member(string name, string schoolClass)
        {
            this.name = name;
            this.schoolClass = schoolClass;
        }
    }

    class Team
    {
        private string name;
        private List<Member> members = new List<Member>();

        public Team(string name)
        {
            this.name = name;
        }

        public void addMember(Member m)
        {
            members.Add(m);
        }

        public string getName()
        {
            return name;
        }

        public int getTeamSize()
        {
            return members.Count;
        }
    }

    abstract class Competition
    {
        protected string name;
        protected string date;
        protected List<Team> teams = new List<Team>();

        public string getName(string name)
        {
            return name;
        }

        public void addTeam(Team t)
        {
            teams.Add(t);
        }

        public void logCompetitionData()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.date);

            foreach (Team t in teams)
            {
                Console.WriteLine(t.getName());
            }
        }

    }

    class ITCompetition : Competition
    {
        protected ITClassRoom room;

        public ITCompetition(string name, string date)
        {
            this.name = name;
            this.date = date;
        }
    }

    class CommonCompetition : Competition
    {
        protected CommonCompetition room;

        public CommonCompetition(string name, string date)
        {
            this.name = name;
            this.date = date;
        }
    }

    class SportCompetition : Competition
    {
        protected SportCompetition room;

        public SportCompetition(string name, string date)
        {
            this.name = name;
            this.date = date;
        }
    }

    abstract class Room
    {
        protected int maxPersons;
        protected string name;

        public string getName(string name)
        {
            return name;
        }

        public int getMaxPersons()
        {
            return maxPersons;
        }
    }

    class ITClassRoom : Room
    {
        private int numberOfComputers;

        public ITClassRoom(int computers)
        {
            this.numberOfComputers = computers;
            maxPersons = computers - 2;
        }
    }

    class CommonRoom : Room
    {

        public CommonRoom()
        {
            this.maxPersons = 32;
        }
        public CommonRoom(int maxPersons)
        {
           this.maxPersons = maxPersons;
        }
    }

    class Gym : Room
    {
        public Gym(int maxPersons)
        {
            this.maxPersons= maxPersons;
        }
    }

    internal class Program
        {
            static void Main(string[] args)
            {
                
            }
        }
      }