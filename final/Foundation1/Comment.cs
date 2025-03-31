class Comment
{
    public string name;
    public string comment;

    public Comment(string name, string comment)
    {
        this.name = name;
        this.comment = comment;
    }

    public string DisplayComment()
    {
        return $"Name: {name}, Comment: {comment}";
    }

}