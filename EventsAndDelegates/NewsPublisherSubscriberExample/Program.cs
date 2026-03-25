using System;

public class NewsArticle
{
    public string Title { get; }
    public string Content { get; }

    public NewsArticle(string title, string content)
    {
        Title = title;
        Content = content;
    }
}

public class ArticleEventArgs : EventArgs
{
    public NewsArticle Article { get; }
    public DateTime PublishingDate { get; }
    public bool IsUrgent { get; }

    public ArticleEventArgs(NewsArticle article, bool isUrgent)
    {
        Article = article;
        PublishingDate = DateTime.Now;
        IsUrgent = isUrgent;
    }
}

public class Publisher
{
    public event EventHandler<ArticleEventArgs> NewNewsPublished;

    public void Publish(NewsArticle article, bool isUrgent)
    {
        var e = new ArticleEventArgs(article, isUrgent);
        RaiseNewNewsPublished(e);
    }

    private void Publish(ArticleEventArgs e)
    {
        RaiseNewNewsPublished(e);
    }

    protected virtual void RaiseNewNewsPublished(ArticleEventArgs e)
    {
        NewNewsPublished?.Invoke(this, e);
    }
}

public class Subscriber
{
    public string Name { get; }

    public Subscriber(string name)
    {
        Name = name;
    }

    public void Subscribe(Publisher publisher)
    {
        publisher.NewNewsPublished += HandleNewNewsPublished;
    }

    public void UnSubscribe(Publisher publisher)
    {
        publisher.NewNewsPublished -= HandleNewNewsPublished;
    }

    private void HandleNewNewsPublished(object sender, ArticleEventArgs e)
    {
        Console.WriteLine($"--- {Name} ---");
        Console.WriteLine($"Title: {e.Article.Title}");
        Console.WriteLine($"Content: {e.Article.Content}");
        Console.WriteLine($"Date: {e.PublishingDate}");
        Console.WriteLine($"Urgent: {e.IsUrgent}\n");
    }
}

internal static class Program
{
    static void Main()
    {
        var publisher = new Publisher();

        var sub1 = new Subscriber("Subscriber 1");
        var sub2 = new Subscriber("Subscriber 2");

        var article = new NewsArticle("Title 1", "Content 1");

        sub1.Subscribe(publisher);
        sub2.Subscribe(publisher);

        publisher.Publish(article, true);

        sub2.UnSubscribe(publisher);

        publisher.Publish(article, false);

        sub1.UnSubscribe(publisher);

        publisher.Publish(article, true);
    }
}