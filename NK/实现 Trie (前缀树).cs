using System.Collections.Generic;

public class Trie
{

    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        public bool IsEndOfWord = false;
    }
    private readonly TrieNode root;

    public Trie()
    {
        root = new TrieNode();
    }

    public void Insert(string word)
    {
        TrieNode node = this.root;
        foreach (var c in word)
        {
            if (!node.Children.ContainsKey(c))
            {
                node.Children.Add(c, new TrieNode());
            }
            node = node.Children[c];
        }
        node.IsEndOfWord = true;

    }

    public bool Search(string word)
    {
        TrieNode node = this.root;
        foreach (var c in word)
        {
            if (!node.Children.ContainsKey(c))
            {
                return false;
            }
            node = node.Children[c];
        }
        return node.IsEndOfWord;

    }

    public bool StartsWith(string prefix)
    {
        TrieNode node = this.root;
        foreach (var c in prefix)
        {
            if (!node.Children.ContainsKey(c))
            {
                return false;
            }
            node = node.Children[c];
        }
        return true;

    }
}

