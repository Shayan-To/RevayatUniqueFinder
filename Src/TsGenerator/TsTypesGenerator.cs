using System.Reflection;

public class TsTypesGenerator
{
    public TsTypesGenerator(TextWriter writer)
    {
        this.Writer = writer;
    }

    private bool FinishBefore()
    {
        if (this.sthBefore)
        {
            this.Writer.WriteLine();
            this.sthBefore = false;
            return true;
        }
        return false;
    }

    private void WriteSemi()
    {
        this.Writer.Write(";");
    }

    private void WriteExpression(string value)
    {
        this.Writer.Write(value);
        this.sthBefore = true;
    }

    private void WriteStatement(string value, bool emptyLineBefore = false)
    {
        if (this.FinishBefore() && emptyLineBefore)
        {
            this.Writer.WriteLine();
        }
        this.Writer.Write(value);
        this.sthBefore = true;
    }

    private LambdaCallDisposable WriteBlock()
    {
        this.Writer.WriteLine(" {");
        this.sthBefore = false;
        return new LambdaCallDisposable(() =>
        {
            this.Writer.Write("}");
            this.sthBefore = true;
        });
    }

    public void WriteType(Type type)
    {
        this.WriteStatement($"export interface {type.Name}", true);
        if (type.BaseType != typeof(object) && type.BaseType != null)
        {
            this.WriteExpression($"extends {type.BaseType.Name}");
        }

        using (this.WriteBlock())
        {
            foreach (var prop in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                
            }
        }
    }

    public TextWriter Writer { get; }

    private bool sthBefore = false;
}
