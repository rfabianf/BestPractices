using System;

namespace PropertyDependencies
{
    public class Person : PropertyNotificationSupport
    {
        public Person()
        {
            canVote = property(nameof(CanVote), () => Age >= 16 && Citizen);
        }
        private int age;
        public int Age
        { get => age;
            set
            {
                //4->5
                //false->false
                //var oldCanVote = CanVote

                if (value == age) return;
                age = value;
                OnPropertyChanged();
                //OnPropertyChanged(nameof(CanVote));

                //if(oldCanVote != CanVote)
                //{
                //    OnPropertyChanged(nameof(CanVote));
                //}
            }
        }

        private bool citizen;
        public bool Citizen
        {
            get => citizen;
            set
            {
                if (value == citizen) return;
                citizen = value;
                OnPropertyChanged();
            }
        }

        private string sex;

        public string Sex
        {
            get => sex;
            set
            {
                if (value == sex) return;
                sex = value;
                OnPropertyChanged();
            }
        }

        //public bool CanVote => Age >= 16;

        //Utilizamos árboles de Expression
        private readonly Func<bool> canVote;
        public bool CanVote => canVote();

        //public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

    }
}
