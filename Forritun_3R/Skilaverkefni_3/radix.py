def radix_sort(random_list):
    len_random_list = len(random_list)
    modulus = 10
    div = 1
    while True:
        # empty array, [[] for i in range(10)]
        new_list = [[], [], [], [], [], [], [], [], [], []]
        for value in random_list:
            least_digit = value % modulus
            least_digit /= div
            new_list[least_digit].append(value)
        modulus = modulus * 10
        div = div * 10

        if len(new_list[0]) == len_random_list:
            return new_list[0]

        random_list = []
        rd_list_append = random_list.append
        for x in new_list:
            for y in x:
                rd_list_append(y)

random_data = [3,2,1,5,4,10,9,8,7,6,15,14,13,12,11,20,19,18,17,16,30,29,28,27,26,25,24,23,22,21]
import time
start = time.time()
radix_sort(random_data)
end = time.time() - start
print(end)