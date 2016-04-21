class Node(object):
 
    def __init__(self, data, left=null,right=null):
        self.data = data
        self.left = left
        self.right = right
 
 
class DoubleList(object):
 
    head = None
    tail = None
 
    def append(self, data):
        new_node = Node(data, None, None)
        if self.head is None:
            self.head = self.tail = new_node
        else:
            new_node.left = self.tail
            new_node.right = None
            self.tail.right = new_node
            self.tail = new_node

    def head(self):
    	return self.head

    def foot(self):
    	return self.tail

    def delete(self, node_value):
    	current_node = self.head
    	while current_node is not None:
    		if current_node.data == node_value:
    			current_node = None
    		current_node = current_node.right

    def delete_index(self, index):
    	current_node = self.head
    	for x in xrange(0,index):
    		current_node = self.right
    	current_node = None
    	
    def clear(self):
    	current_node = self.head
    	while current_node in not None:
    		current_node = None
    		current_node = current_node.right

    def search(self, node_value):
    	current_node = self.head
    	counter = 0

    	while current_node is not None:
    		if current_node.data == node_value:
    			return counter
    		counter = counter + 1

    def length(self):
    	counter = 0
    	current_node = self.head

    	while current_node is not None:
    		counter = counter + 1
    		current_node = current_node.right
    	return counter

 	def get(self,index):
 		current_node = self.head

 		for x in xrange(0,length()):
 			current_node = self.right

 		return current_node.data

    def remove(self, node_value):
        current_node = self.headlk
 
        while current_node is not None:
            if current_node.data == node_value:
                # if it's not the first element
                if current_node.left is not None:
                    current_node.left.right = current_node.right
                    current_node.right.left = current_node.left
                else:
                    # otherwise we have no left (it's None), head is the right one, and left becomes None
                    self.head = current_node.right
                    current_node.right.left = None
 
            current_node = current_node.right
 
    def show(self):
        print "Show list data:"
        current_node = self.head
        while current_node is not None:
            print current_node.left.data if hasattr(current_node.left, "data") else None,
            print current_node.data,
            print current_node.right.data if hasattr(current_node.right, "data") else None
 
            current_node = current_node.right
        print "*"*50
 
 
d = DoubleList()
 
d.append(5)
d.append(6)
d.append(50)
d.append(30)
 
d.show()
 
d.remove(50)
d.remove(5)
 
d.show()