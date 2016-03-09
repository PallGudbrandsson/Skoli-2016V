def counting_sort(array, maxval):
    """in-place counting sort"""
    m = maxval + 1
    count = [0] * m               # init with zeros
    for a in array:
        count[a] += 1             # count occurences
    i = 0
    for a in range(m):            # emit
        for c in range(count[a]): # - emit 'count[a]' copies of 'a'
            array[i] = a
            i += 1
    return (array)

import time()

start = time.time
counting_sort([3,1,2,5,4,6,9,7,8,10,15,11,13,12,14,17,19,20,16,18,30,29,28,22,21,24,26,25,27,25,23], 30)
end = time.time() - start
print(end)