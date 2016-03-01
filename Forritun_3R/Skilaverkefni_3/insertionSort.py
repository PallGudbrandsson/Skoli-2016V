lista = [2,5,4,1,6,7,3,8,9,10]
new_list = []

#Byrja a indexi 1
#sja hvort naesta a eftir er minna
#ef svo er senda i method sem finnur rett index
#annars skilja thad eftir
#svo haekka indexid
"""
def insert(index):
	for x in xrange(1,index,-1):
		i = x-1
		val = lista[i]
		while i >= 0 and x[i] > val:
			s[j+1] = s[j]
			j = j - 1
		lista.append(val)
"""
def insert(s):
    for i in range(1, len(s)):
        val = s[i]#Tekur gildid sem er verid ad vinna med og vistar thad i breytu
        j = i - 1#vistar gildid a undan sem j
        while (j >= 0) and (s[j] > val): #j er staerra eda = 0 og gildi j er staerra en gildid
            s[j+1] = s[j]#Setur gildid a eftir sem gildid a undan
            j = j - 1#laekkar j um 1
        s[j+1] = val#Setur gildid a undan j = val
		

insert(lista)

print(lista)