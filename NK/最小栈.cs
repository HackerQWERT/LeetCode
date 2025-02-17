using System.Collections;
using System.Collections.Generic;

public class MinStack
{
    private Stack<int> stack = new Stack<int>();
    private Stack<int> minStack = new Stack<int>();

    public MinStack()
    {


    }

    public void Push(int val)
    {
        stack.Push(val);
        if (minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
    }

    public void Pop()
    {
        int v = stack.Pop();
        if (v == minStack.Peek())
        {
            minStack.Pop();
        }

    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */