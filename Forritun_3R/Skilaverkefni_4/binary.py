class Node:
    def __init__(self, val):
        self.l_child = None
        self.r_child = None
        self.data = val

def tree_insert:(root, node):
    if root is None:
        root = node
    else:
        if root.data > node.data:
            if root.l_child is None:
                root.l_child = node
            else:
                tree_insert(root.l_child, node)
        else:
            if root.r_child is None:
                root.r_child = node
            else:
                tree_insert(root.r_child, node)

def inorder_tree_walk(root):
    if not root:
        return None
    inorder_tree_walk(root.l_child)
    print root.data
    inorder_tree_walk(root.r_child)



def tree_search(root, value):
    if not root:
        return None


r = Node(3)

tree_insert:(r, Node(7))
tree_insert(r, Node(1))
tree_insert(r, Node(5))


print "in order:"
inorder_tree_walk(r)

