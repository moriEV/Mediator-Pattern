using Mediator_Pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        ChatMediator chatMediator = new ChatMediator();

        // Создаем пользователей
        User user1 = new User("Alice");
        User user2 = new User("Bob");
        User user3 = new User("Charlie");

        // Добавляем пользователей в чат
        chatMediator.AddUser(user1);
        chatMediator.AddUser(user2);
        chatMediator.AddUser(user3);

        // Пользователи отправляют сообщения
        user1.SendMessage("Привет, Боб!", "Bob");
        user2.SendMessage("Привет, Алиса!", "Alice");
        user3.SendMessage("Как дела, Алиса?", "Alice");
        user3.SendMessage("Как дела, Гена", "Gena");
        // Отображение истории сообщений
        user1.ShowMessageHistory();
        user2.ShowMessageHistory();
        user3.ShowMessageHistory();
    }
}