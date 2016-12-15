// https://leetcode.com/problems/implement-trie-prefix-tree/
// Implement a trie with insert, search, and startsWith methods.

// Note:
// You may assume that all inputs are consist of lowercase letters a-z.

public class TrieNode {
    // Initialize your data structure here.
    public string data = "";
    public bool isLeaf = false;
    public TrieNode[] children = new TrieNode[26];
    public TrieNode() {
        
    }
}

public class Trie {
    private TrieNode root;

    public Trie() {
        root = new TrieNode();
    }

    // Inserts a word into the trie.
    public void Insert(String word)
    {
        TrieNode p = root;
        
        for(int i =0; i < word.Length; i++)
        {
            if(p.children[word[i]- 'a'] == null)
            {
                p.children[word[i]-'a'] = new TrieNode();
            }
            p = p.children[word[i]-'a'];
        }
        p.isLeaf = true;
    }

    // Returns if the word is in the trie.
    public bool Search(string word) {
        TrieNode p = SearchWord(word);
        if(p != null && p.isLeaf)
            return true;
        return false;
    }

    // Returns if there is any word in the trie
    // that starts with the given prefix.
    public bool StartsWith(string word) {
        TrieNode p = SearchWord(word);
        if(p != null)
            return true;
        return false;
    }
    
    public TrieNode SearchWord(string word) {
        TrieNode p = root;
        for(int i =0; i < word.Length; i++)
        {
            if(p.children[word[i]-'a'] == null)
            {
                return null;
            }
            p = p.children[word[i]-'a'];
        }
        return p;
    }
}

// Your Trie object will be instantiated and called as such:
// Trie trie = new Trie();
// trie.Insert("somestring");
// trie.Search("key");