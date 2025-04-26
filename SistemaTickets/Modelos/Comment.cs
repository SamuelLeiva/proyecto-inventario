using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTickets.Modelos;

public class Comment
{
    public int Id { get; private set; }
    public string Author { get; private set; }
    public string Text { get; private set; }
    public DateTime CreatedDate { get; private set; } = DateTime.Now;

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }
}
