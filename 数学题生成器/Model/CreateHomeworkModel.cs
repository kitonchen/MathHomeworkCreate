using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Reflection;


namespace homework_create
{
<<<<<<< HEAD
    public class CreateHomewordModel : ModelLinker, INotifyPropertyChanged
=======
    public class CreateHomeworkModel : INotifyPropertyChanged
>>>>>>> 2053cebe17d54cb9a055816498b5f23e28cb740c
   {
        private Config mconfig;
        private QuestionCreate mquestionCreate;

<<<<<<< HEAD
        public CreateHomewordModel()
=======
        public CreateHomeworkModel()
>>>>>>> 2053cebe17d54cb9a055816498b5f23e28cb740c
        {

        }

        public Config Mconfig { get => mconfig;
            set
            {
                if(mconfig != value)
                {
                    mconfig = value;
                    OnPropertyChanged("Mconfig");
                }
            }
        }

        public QuestionCreate MquestionCreate { get => mquestionCreate;
            set
            {
                if(mquestionCreate != value)
                {
                    mquestionCreate = value;
                    OnPropertyChanged("MquestionCreate");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
   }

    //配置，类型，数量，数值范围
    public struct Config
    {
        private ArrayList types;
        private int nums;
        private int rangMin;
        private int rangMax;

        public ArrayList Types { get => types; set => types = value; }
        public int Nums { get => nums; set => nums = value; }
        public int RangMin { get => rangMin; set => rangMin = value; }
        public int RangMax { get => rangMax; set => rangMax = value; }

        //重写equals
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;

            return Equals((Config)obj);
        }

        //重写hashcode
        public override int GetHashCode()
        {
            return this.Nums ^ this.RangMax ^ this.RangMin ^ this.Types.Count;
        }

        public static bool operator ==(Config lhs, Config rhs)
        {
            return (lhs.Nums == rhs.Nums) && (lhs.Types == rhs.Types) && (lhs.RangMax == rhs.RangMax) && (lhs.RangMin == rhs.RangMin);
        }

        public static bool operator !=(Config lhs, Config rhs)
        {
            return !(lhs == rhs);
        }
    }

    public class QuestionCreate
    {
        private string msavepath =null;
        private string mfiledate =null;

        public string Msavepath { get => msavepath; set => msavepath = value; }
        public string Mfiledate { get => mfiledate; set => mfiledate = value; }

        ~QuestionCreate()
        {
            msavepath = null;
            Mfiledate = null;
        }   
    }

    
}
