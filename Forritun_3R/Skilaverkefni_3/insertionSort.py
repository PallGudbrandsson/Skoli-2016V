lista = [3,1,2,5,4,6,9,7,8,10,15,11,13,12,14,17,19,20,16,18,30,29,28,22,21,24,26,25,27,25,23]
new_list = []
import time
def insert(s):
    for i in range(1, len(s)):
        val = s[i]#Tekur gildid sem er verid ad vinna med og vistar thad i breytu
        j = i - 1#vistar gildid a undan sem j
        while (j >= 0) and (s[j] > val): #j er staerra eda = 0 og gildi j er staerra en gildid
            s[j+1] = s[j]#Setur gildid a eftir sem gildid a undan
            j = j - 1#laekkar j um 1
        s[j+1] = val#Setur gildid a undan j = val
		
start = time.time()
insert(lista)
end = time.time() - start 
print(end)