class Node(object):
 
      def __init__(self, data, next):
            self.data = data
            self.next = next
 
 
class SingleList(object):
 
      head = None
      tail = None

      def show(self):
            print "Showing list data:"
            current_node = self.head
            while current_node is not None:
                  print current_node.data, " -> ",
                  current_node = current_node.next
            print None

      def get(self, index):
            current_node = self.head
            for x in xrange(0,index):
                  current_node = current_node.next
            return current_node

      def length(self):
            counter = 0
            current_node = self.head
            while current_node is not None:
                  counter = counter + 1
                  current_node = current_node.next
            return counter

      def search(self, value):
            current_node = self.head
            for x in xrange(0,self.length):
                  if current_node.data == value:
                        return current_node.data
                  current_node = current_node.next

      def delete(self,value):
            current_node = self.head
            for x in xrange(0,self.length):
                  if current_node.data == value:
                        current_node.data = None
                  current_node = current_node.next
      def delete_index(self,value):
            current_node = self.head
            for x in xrange(0,value):
                  current_node = current_node.next
            current_node = None

      def clear(self):
            current_node = self.head
            while current_node is not None:
                  lol = current_node.next
                  current_node = None
                  current_node = lol

      def foot(self):
            return self.tail
 
      def add(self, data):
            node = Node(data, None)
            if self.head is None:
                  self.head = self.tail = node
            else:
                  self.tail.next = node
            self.tail = node
 
      def delete(self, node_value):
            current_node = self.head
            previous_node = None
            while current_node is not None:
                  if current_node.data == node_value:
                  # if this is the first node (head)
                        if previous_node is not None:
                              previous_node.next = current_node.next
                  else:
                         self.head = current_node.next
 
            # needed for the next iteration
                  previous_node = current_node
                  current_node = current_node.next

      def head(self):
            return self.head

 
 
s = SingleList()
s.add(31)
s.add(2)
s.add(3)
s.add(4)
 
s.show()
s.delete(31)
s.delete(3)
s.delete(2)
s.show()