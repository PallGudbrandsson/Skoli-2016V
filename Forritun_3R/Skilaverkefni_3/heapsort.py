def heapsort(lst):
 
  # in pseudo-code, heapify only called once, so inline it here
  for start in range((len(lst)-2)/2, -1, -1):
    siftdown(lst, start, len(lst)-1)
 
  for end in range(len(lst)-1, 0, -1):
    lst[end], lst[0] = lst[0], lst[end]
    siftdown(lst, 0, end - 1)
  return lst
 
def siftdown(lst, start, end):
  root = start
  while True:
    child = root * 2 + 1
    if child > end: break
    if child + 1 <= end and lst[child] < lst[child + 1]:
      child += 1
    if lst[root] < lst[child]:
      lst[root], lst[child] = lst[child], lst[root]
      root = child
    else:
      break
ary = [3,2,1,5,4,10,9,8,7,6,15,14,13,12,11,20,19,18,17,16,30,29,28,27,26,25,24,23,21]
import time
start = time.time()
heapsort(ary)
end = time.time() - start
print(end)