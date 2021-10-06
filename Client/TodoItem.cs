namespace BlazorApp.Client
{
    <!-- This class is used to make each item in the todo list-->
    public class TodoItem
    {
        public string Title { get; set; }   <!-- This will set the title of the item in the list-->
        public bool IsDone { get; set; }    <!-- This will allow the user to check off items in the list as 'done' -->
    }
}