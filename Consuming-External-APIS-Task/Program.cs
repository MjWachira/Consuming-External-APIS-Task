
using Consuming_External_APIS_Task.Controllers;

Console.WriteLine("Hello, World!");
UserController userController = new UserController();
PostsController postsController = new PostsController();
CommentsController commentsController = new CommentsController();



Console.WriteLine("Choose an option:");
Console.WriteLine("1. Display Users");
Console.WriteLine("2. Display Posts");
Console.WriteLine("3. Display Comments");


switch (Console.ReadLine())
{
    case "1":
        await userController.getUsers();
        break;
    case "2":
        await postsController.getPosts();
        break;
    case "3":
        await commentsController.getComments();
        break;
}