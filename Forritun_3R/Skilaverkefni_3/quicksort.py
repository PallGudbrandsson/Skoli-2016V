def partition(lst, start, end):
    pos = start                           # condition was obsolete, loop won't
                                          # simply run for empty range

    for i in range(start, end):           # i must be between start and end-1
        if lst[i] < lst[end]:             # in your version it always goes from 0
            lst[i],lst[pos] = lst[pos],lst[i]
            pos += 1

    lst[pos],lst[end] = lst[end],lst[pos] # you forgot to put the pivot
                                          # back in its place
    return pos

def quick_sort_recursive(lst, start, end):
    if start < end:                       # this is enough to end recursion
        pos = partition(lst, start, end)
        quick_sort_recursive(lst, start, pos - 1)
        quick_sort_recursive(lst, pos + 1, end)
                 

example = [3,1,2,5,4,6,9,7,8,10,15,11,13,12,14,17,19,20,16,18,30,29,28,22,21,24,26,25,27,25,23]

import time

start = time.time()

quick_sort_recursive(example, 0, len(example) - 1)

end = time.time() - start
print (end)