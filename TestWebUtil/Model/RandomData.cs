﻿using System;
using System.Collections.Generic;

namespace UnitTest
{
    public class PublicData
    {
        protected static readonly Random rnd = new Random();
    }

    public class FIOData : PublicData
    {
        private static List<string> listNameMans = new List<string>() { "Абрам", "Аваз", "Авраам", "Адам", "Аким", "Алан", "Александр", "Алексей", "Али", "Алихан", "Альберт", "Анатолий", "Ангел", "Андрей", "Антон", "Арам", "Аркадий", "Арман", "Армен", "Арсений", "Арслан", "Артем", "Артемий", "Артур", "Ахмет", "Ашот", "Богдан", "Борис", "Борислав", "Вадим", "Валентин", "Валерий", "Вальдемар", "Вардан", "Василий", "Виктор", "Вильгельм", "Вит", "Виталий", "Владимир", "Владислав", "Владлен", "Всеволод", "Вячеслав", "Гарри", "Геннадий", "Генрих", "Георгий", "Герасим", "Герман", "Глеб", "Григорий", "Давид", "Дамир", "Даниил", "Денис", "Джамал", "Джеймс", "Джереми", "(Иеремия)", "Дик", "Дино", "Дмитрий", "Добрыня", "Евгений", "Евстахий", "Егор", "Елисей", "Емельян", "Еремей", "Ефим", "Ефрем", "Захар", "Ибрагим", "Иван", "Игорь", "Иероним", "(Джером)", "Илья", "Иннокентий", "Исаак", "Исидор", "Исмаил", "Камиль", "Карен", "Карл", "Ким", "Кирилл", "Клаус", "Конрад", "Константин", "Кузьма", "Лев", "Леон", "Леонид", "Лука", "Лукиллиан", "Лукьян", "Людвиг", "Людовик", "Люций", "Максим", "Максимилиан", "Максуд", "Марат", "Марк", "Мартин", "(Мартын)", "Матвей", "Махмуд", "Мика", "Микула", "Мирослав", "Михаил", "Мстислав", "Мурат", "Муслим", "Мухаммед", "Назар", "Никита", "Никодим", "Никола", "Николай", "Нильс", "Олег", "Орландо", "Осип", "(Иосиф)", "Оскар", "Остап", "Павел", "Педро", "Петр", "Равиль", "Раймонд", "Рамиз", "Рамиль", "Рамон", "Расим", "Ратмир", "Рафаэль", "Рафик", "Рашид", "Ринат", "(Ренат)", "Ричард", "Роберт", "Родион", "Ролан", "Роман", "Ростислав", "Рубен", "Рудольф", "Руслан", "Рустам", "Рэй", "Савва", "Савелий", "Святослав", "Севастьян", "Семен", "Сергей", "Сидор", "Станислав", "Степан", "Тамаз", "Тарас", "Тигран", "Тимофей", "Тимур", "Тихон", "Томас", "Федор", "Федот", "Феликс", "Филипп", "Фома", "Фред", "Фридрих", "Харитон", "Чарльз", "Чеслав", "Шамиль", "Эдгар", "Эдуард", "Эльдар", "Эмиль", "Эмин", "Эрик", "Эрмин", "Юрий", "Яков", "Ян", "Ярослав" };
        private static List<string> listNameWomen = new List<string>() { "Авдотья", "Агунда", "Аделаида", "Аделина", "Адель", "Айгуль", "Аксинья", "Алевтина", "Александра", "Алена", "Алина", "Алиса", "Алла", "Алсу", "Альба", "Альбина", "Аля", "Амалия", "Амина", "Анастасия", "Ангелина", "Анжела", "Анжелика", "Анисья", "Анна", "Антонина", "Аполлинария", "Арина", "Астрид", "Белла", "Берта", "Валентина", "Валерия", "Варвара", "Василиса", "Вера", "Вероника", "Виктория", "Виолетта", "Вита", "Влада", "Владислава", "Галина", "Грета", "Гульнара", "Гюзель", "Дамира", "Дарина", "Дарья", "Джамиля", "Диана", "Диля", "Дилярам", "Дина", "Динара", "Ева", "Евгения", "Евдокия", "Екатерина", "Елена", "Елизавета", "Есения", "Жанна", "Жозефина", "Забава", "Зара", "Зарина", "Зинаида", "Злата", "Зоя", "Зухра", "Изабелла", "Илона", "Инга", "Инна", "Иоанна", "Ира", "Ираида", "Ирина", "Ирма", "Искра", "Ия", "Камила", "Камилла", "Карина", "Каролина", "Кира", "Клавдия", "Клара", "Кристина", "Ксения", "Лада", "Лариса", "Лаура", "Лейла", "Лиана", "Лидия", "Лилиана", "Лилия", "Лина", "Линда", "Луиза", "Любовь", "Людмила", "Магдалeна", "Мадина", "Мадлен", "Майя", "Маргарита", "Марианна", "Марина", "Мария", "Мика", "Мила", "Милада", "Милана", "Милена", "Милица", "Мирослава", "Моника", "Надежда", "Наиля", "Наталья", "Ника", "Нина", "Нинель", "Нурия", "Оксана", "Олеся", "Ольга", "Полина", "Прасковья", "Рада", "Раиса", "Регина", "Рена", "Рената", "Рикарда", "Римма", "Рина", "Рита", "Роза", "Сабина", "Сабрина", "Сажида", "Саида", "Сандра", "Сара", "Сати", "Светлана", "Серафима", "Сильвия", "Снежана", "Соня", "Софья", "Сусанна", "Таисия", "Тамара", "Татьяна", "Тереза", "Ульяна", "Урсула", "Фаина", "Фатима", "Фредерика", "Фрида", "Цветана", "Чулпан", "Шакира", "Шарлотта", "Эвелина", "Элиза", "Элина", "Элла", "Эльвира", "Эльмира", "Эмили", "Эмилия", "Эмма", "Эрика", "Эрмина", "Этель", "Этери", "Юлия", "Юния", "Юнона", "Ядвига", "Яна", "Янина" };
        private static List<string> listLastName = new List<string>() { "Абрамов", "Авдеев", "Агафонов", "Аксёнов", "Александров", "Алексеев", "Андреев", "Анисимов", "Антонов", "Артемьев", "Архипов", "Афанасьев", "Баранов", "Белов", "Белозёров", "Белоусов", "Беляев", "Беляков", "Беспалов", "Бирюков", "Блинов", "Блохин", "Бобров", "Бобылёв", "Богданов", "Большаков", "Борисов", "Брагин", "Буров", "Быков", "Васильев", "Веселов", "Виноградов", "Вишняков", "Владимиров", "Власов", "Волков", "Воробьёв", "Воронов", "Воронцов", "Гаврилов", "Галкин", "Герасимов", "Голубев", "Горбачёв", "Горбунов", "Гордеев", "Горшков", "Григорьев", "Гришин", "Громов", "Гуляев", "Гурьев", "Гусев", "Гущин", "Давыдов", "Данилов", "Дементьев", "Денисов", "Дмитриев", "Доронин", "Дорофеев", "Дроздов", "Дьячков", "Евдокимов", "Евсеев", "Егоров", "Елисеев", "Емельянов", "Ермаков", "Ершов", "Ефимов", "Ефремов", "Жданов", "Жуков", "Журавлёв", "Зайцев", "Захаров", "Зимин", "Зиновьев", "Зуев", "Зыков", "Иванков", "Иванов", "Игнатов", "Игнатьев", "Ильин", "Исаев", "Исаков", "Кабанов", "Казаков", "Калашников", "Калинин", "Капустин", "Карпов", "Кириллов", "Киселёв", "Князев", "Ковалёв", "Козлов", "Колесников", "Колобов", "Комаров", "Комиссаров", "Кондратьев", "Коновалов", "Кононов", "Константинов", "Копылов", "Корнилов", "Королёв", "Костин", "Котов", "Кошелев", "Красильников", "Крылов", "Крюков", "Кудрявцев", "Кудряшов", "Кузнецов", "Кузьмин", "Кулагин", "Кулаков", "Куликов", "Лаврентьев", "Лазарев", "Лапин", "Ларионов", "Лебедев", "Лихачёв", "Лобанов", "Логинов", "Лукин", "Лыткин", "Макаров", "Максимов", "Мамонтов", "Марков", "Мартынов", "Маслов", "Матвеев", "Медведев", "Мельников", "Меркушев", "Миронов", "Михайлов", "Михеев", "Мишин", "Моисеев", "Молчанов", "Морозов", "Муравьёв", "Мухин", "Мышкин", "Мясников", "Назаров", "Наумов", "Некрасов", "Нестеров", "Никитин", "Никифоров", "Николаев", "Никонов", "Новиков", "Носков", "Носов", "Овчинников", "Одинцов", "Орехов", "Орлов", "Осипов", "Павлов", "Панов", "Панфилов", "Пахомов", "Пестов", "Петров", "Петухов", "Поляков", "Пономарёв", "Попов", "Потапов", "Прохоров", "Рогов", "Родионов", "Рожков", "Романов", "Русаков", "Рыбаков", "Рябов", "Савельев", "Савин", "Сазонов", "Самойлов", "Самсонов", "Сафонов", "Селезнёв", "Селиверстов", "Семёнов", "Сергеев", "Сидоров", "Силин", "Симонов", "Ситников", "Соболев", "Соколов", "Соловьёв", "Сорокин", "Степанов", "Стрелков", "Субботин", "Суворов", "Суханов", "Сысоев", "Тарасов", "Терентьев", "Тетерин", "Тимофеев", "Титов", "Тихонов", "Третьяков", "Трофимов", "Туров", "Уваров", "Устинов", "Фадеев", "Фёдоров", "Федосеев", "Федотов", "Филатов", "Филиппов", "Фокин", "Фомин", "Фомичёв", "Фролов", "Харитонов", "Хохлов", "Цветков", "Чернов", "Шарапов", "Шаров", "Шашков", "Шестаков", "Шилов", "Ширяев", "Шубин", "Щербаков", "Щукин", "Юдин", "Яковлев", "Якушев" };
        private static List<string> listMiddleNameMans = new List<string>() { "Александрович", "Алексеевич", "Анатольевич", "Андреевич", "Антонович", "Аркадьевич", "Артемович", "Бедросович", "Богданович", "Борисович", "Валентинович", "Валерьевич", "Васильевич", "Викторович", "Витальевич", "Владимирович", "Владиславович", "Вольфович", "Вячеславович", "Геннадиевич", "Георгиевич", "Григорьевич", "Данилович", "Денисович", "Дмитриевич", "Евгеньевич", "Егорович", "Ефимович", "Иванович", "Иваныч", "Игнатьевич", "Игоревич", "Ильич", "Иосифович", "Исаакович", "Кириллович", "Константинович", "Леонидович", "Львович", "Максимович", "Матвеевич", "Михайлович", "Николаевич", "Олегович", "Павлович", "Палыч", "Петрович", "Платонович", "Робертович", "Романович", "Саныч", "Северинович", "Семенович", "Сергеевич", "Станиславович", "Степанович", "Тарасович", "Тимофеевич", "Федорович", "Феликсович", "Филиппович", "Эдуардович", "Юрьевич", "Яковлевич", "Ярославович" };
        private static List<string> listMiddleNameWomen = new List<string>() { "Александровна", "Алексеевна", "Анатольевна", "Андреевна", "Антоновна", "Аркадьевна", "Артемовна", "Богдановна", "Борисовна", "Валентиновна", "Валерьевна", "Васильевна", "Викторовна", "Виталиевна", "Владимировна", "Владиславовна", "Вячеславовна", "Геннадиевна", "Георгиевна", "Григорьевна", "Даниловна", "Денисовна", "Дмитриевна", "Евгеньевна", "Егоровна", "Ефимовна", "Ивановна", "Игоревна", "Ильинична", "Иосифовна", "Кирилловна", "Константиновна", "Леонидовна", "Львовна", "Максимовна", "Матвеевна", "Михайловна", "Николаевна", "Олеговна", "Павловна", "Петровна", "Платоновна", "Робертовна", "Романовна", "Семеновна", "Сергеевна", "Станиславовна", "Степановна", "Тарасовна", "Тимофеевна", "Федоровна", "Феликсовна", "Филипповна", "Эдуардовна", "Юрьевна", "Яковлевна", "Ярославовна" };

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }

        public FIOData()
        {
            if (rnd.Next(2) == 1)
            {
                Name = listNameMans[rnd.Next(listNameMans.Count)];
                LastName = listLastName[rnd.Next(listLastName.Count)];
                MiddleName = listMiddleNameMans[rnd.Next(listMiddleNameMans.Count)];
            }
            else
            {
                Name = listNameWomen[rnd.Next(listNameWomen.Count)];
                LastName = listLastName[rnd.Next(listLastName.Count)] + "a";
                MiddleName = listMiddleNameWomen[rnd.Next(listMiddleNameWomen.Count)];
            }
        }

        public static string RandomLastName()
        {
            return rnd.Next(2) == 1 ? listLastName[rnd.Next(listLastName.Count)] : (listLastName[rnd.Next(listLastName.Count)] + "a");
        }
    }

    public class Phone : PublicData
    {
        public static string RandomPhone()
        {
            string phone = "+";
            for (int i = 0; i < 11; i++)
                phone += rnd.Next(10);

            return phone;
        }
    }

    public class Login : PublicData
    {
        public static string RandomLogin()
        {
            return "testLogin";
        }
    }

    public class Email : PublicData
    {
        public static string RandomEmail()
        {
            return "email@domen.ru";
        }
    }

    public class Password : PublicData
    {
        public static string RandomPassword()
        {
            return "Password32";
        }
    }
}