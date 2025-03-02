namespace ClassLibrary2
{

    public class Administration
    {
        private string _position = "Undefined";
        private string _responsibilities = "Undefined";
        private int _subordinatesCount;

        public double BaseRate = 1.5;

        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }
        public string Responsibilities
        {
            get
            {
                return _responsibilities;
            }
            set
            {
                _responsibilities = value;
            }
        }
        public int SubordinatesCount
        {
            get
            {
                return _subordinatesCount;
            }
            set
            {
                _subordinatesCount = value;
            }
        }

        public void ConductMeeting()
        {
            Console.WriteLine();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"РџРѕР·РёС†РёСЏ: {_position} \n РћР±СЏР·Р°РЅРЅРѕСЃС‚Рё: {_responsibilities} \n РљРѕР»РёС‡РµСЃС‚РІРѕ РїРѕРґС‡РёРЅРµРЅРЅС‹С…: {_subordinatesCount}");
        }

        public void FillData(string position, string responsibilities, string subordinatesCount)
        {
            Position = position;
            Responsibilities = responsibilities;
            SubordinatesCount = Int32.Parse(subordinatesCount);
        }

    }

    public class Engineer : Worker
    {
        private string _specialization = "Undefined";
        private string _qualification = "Undefined";
        private int _designExperience;

        public string Specialization
        {
            get
            {
                return _specialization;
            }
            set
            {
                _specialization = value;
            }
        }
        public string Qualification
        {
            get
            {
                return _qualification;
            }
            set
            {
                _qualification = value;
            }
        }
        public int DesignExperience
        {
            get
            {
                return _designExperience;
            }
            set
            {
                _designExperience = value;
            }
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"РЎРїРµС†РёР°Р»СЊРЅРѕСЃС‚СЊ: {_specialization} \n РљРІР°Р»РёС„РёРєР°С†РёСЏ: {_qualification} \n РћРїС‹С‚: {_designExperience}");
        }
        public void ChangeSpecialization(string NewSpecialization)
        {
            Specialization = NewSpecialization;
            Console.WriteLine($"РЎРїРµС†РёР°Р»СЊРЅРѕСЃС‚СЊ СЃРјРµРЅРёР»Р°СЃСЊ СЃ {_specialization} РЅР° {NewSpecialization}");
        }

        public void FillData()
        {
            Console.Write("Р’РІРµРґРёС‚Рµ СЃРїРµС†РёР°Р»СЊРЅРѕСЃС‚СЊ: ");
            Specialization = Console.ReadLine();

            Console.Write("Р’РІРµРґРёС‚Рµ СѓСЂРѕРІРµРЅСЊ РєРІР°Р»РёС„РёРєР°С†РёРё: ");
            Qualification = Console.ReadLine();

            Console.Write("Р’РІРµРґРёС‚Рµ РѕРїС‹С‚: ");
            DesignExperience = int.Parse(Console.ReadLine());
        }

    }

    public class HumanResources
    {
        private int _employeeCount;
        private string _recruitmentMethods = "Undefined";
        private string _accountingSystem = "Undefined";

        public int EmployeeCount
        {
            get
            {
                return _employeeCount;
            }
            set
            {
                _employeeCount = value;
            }
        }
        public string RecruitmentMethods
        {
            get
            {
                return _recruitmentMethods;
            }
            set
            {
                _recruitmentMethods = value;
            }
        }
        public string AccountingSystem
        {
            get
            {
                return _accountingSystem;
            }
            set
            {
                _accountingSystem = value;
            }
        }
        public Worker worker { get; set; } //Р°РіСЂРµРіР°С†РёСЏ

        public void ShowInfo()
        {
            Console.WriteLine($"РљРѕР»РёС‡РµСЃС‚РІРѕ: {_employeeCount} \n РњРµС‚РѕРґ РЅР°Р№РјР°: {_recruitmentMethods} \n РЎРёСЃС‚РµРјР° СѓС‡РµС‚Р°: {_accountingSystem}");
        }

        public void HireWorker()
        {
            Worker worker = new Worker();

            Console.WriteLine("РЈСЂРѕРІРµРЅСЊ РѕР±СЂР°Р·РѕРІР°РЅРёСЏ: ");
            worker.Specialty = Console.ReadLine();

            Console.WriteLine("РЈСЂРѕРІРµРЅСЊ РєРІР°Р»РёС„РёРєР°С†РёРё: ");
            worker.QualificationLevel = Console.ReadLine();

            Console.WriteLine("РћРїС‹С‚: ");
            worker.Experience = int.Parse(Console.ReadLine());
        }

        public void FireEmployee()
        {
            if (_employeeCount > 0)
            {
                _employeeCount--;
                Console.WriteLine($"Р Р°Р±РѕС‚РЅРёРє РЈРІРѕР»РµРЅ.");
            }
        }

        public void FillData()
        {
            Console.Write("Р’РІРµРґРёС‚Рµ РљРѕР»РёС‡РµСЃС‚РІРѕ: ");
            EmployeeCount = int.Parse(Console.ReadLine());

            Console.Write("Р’РІРµРґРёС‚Рµ РњРµС‚РѕРґ РЅР°Р№РјР°: ");
            RecruitmentMethods = Console.ReadLine();

            Console.Write("Р’РІРµРґРёС‚Рµ РЎРёСЃС‚РµРјСѓ СѓС‡РµС‚Р°: ");
            AccountingSystem = Console.ReadLine();
        }
    }

    public class Worker : Administration
    {
        private string _specialty = "Undefined";
        private string _qualificationLevel = "Undefined";
        private int _experience;

        public string Specialty
        {
            get
            {
                return _specialty;
            }
            set
            {
                _specialty = value;
            }
        }
        public string QualificationLevel
        {
            get
            {
                return _qualificationLevel;
            }
            set
            {
                _qualificationLevel = value;
            }
        }
        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                _experience = value;
            }
        }

        public int AddExp()
        {
            return _experience++;
        }

        public double CalculateSalary()
        {
            return BaseRate * _experience;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"РћР±СЂР°Р·РѕРІР°РЅРёРµ: {_specialty} \n РЈСЂРѕРІРµРЅСЊ РєРІР°Р»РёС„РёРєР°С†РёРё: {_qualificationLevel} \n РћРїС‹С‚: {_experience}");
        }

        public void FillData()
        {
            Console.Write("Р’РІРµРґРёС‚Рµ РѕР±СЂР°Р·РѕРІР°РЅРёРµ: ");
            Specialty = Console.ReadLine();

            Console.Write("Р’РІРµРґРёС‚Рµ СѓСЂРѕРІРµРЅСЊ РєРІР°Р»РёС„РёРєР°С†РёРё: ");
            QualificationLevel = Console.ReadLine();

            Console.Write("Р’РІРµРґРёС‚Рµ РѕРїС‹С‚ (С‡РёСЃР»Рѕ): ");
            if (int.TryParse(Console.ReadLine(), out int exp))
            {
                Experience = exp;
            }
            else
            {
                Console.WriteLine("РћС€РёР±РєР° РІРІРѕРґР°. РћРїС‹С‚ СѓСЃС‚Р°РЅРѕРІР»РµРЅ РІ 0.");
                Experience = 0;
            }
        }

    }

}
