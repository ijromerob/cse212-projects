public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if(Data < value)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
          return true;
        }
        else
        {
          if(value < Data)
          {
            if(Left is null)
            {
              return false;
            }
            else
            {
              return Left.Contains(value);
            }
          }
          else
          {

            if(Right is null)
            {
              return false;
            }
            else
            {
              return Right.Contains(value);
            }
          }
        }
    }

    public int GetHeight()
    {
        int rightValue = 0;
        int leftValue = 0;
        if(Right is null && Left is null)
        {
          return 1;
        }
        else
        {
          if(Right is not null)
          {
            rightValue = Right.GetHeight();
          }
          if(Left is not null)
          {
            leftValue = Left.GetHeight();
          }
          if(rightValue > leftValue)
          {
            return 1 + rightValue;
          }
          else{
            return 1 + leftValue;
          }
        }

    }
}