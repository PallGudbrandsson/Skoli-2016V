#1
def find_middle(tala1, tala2, tala3):
    newList = []
    if tala1 > tala2 and tala1 > tala2:
        newList.append(tala2)
        newList.append(tala3)
    if tala2 > tala3 and tala2 > tala3:
        newList.append(tala3)
        newList.append(tala1)
    if tala3 > tala1 and tala3 > tala2:
        newList.append(tala2)
        newList.append(tala1)
    
    if newList[0] > newList [1]:
        return newList[0]
    else:
        return newList[1]


tala = find_middle(9,5,7)
print(str(tala))

#2
def even(OrgList):
    for x in xrange(0,len(OrgList)):
        if OrgList[x] % 2 == 0:
            print("True")
        else:
            print("False")


NewList = [12,3,6,2]
even(NewList)

#3
def asciii(strengur):
    newList = []
    for x in xrange(0, len(strengur)):
        newList.append(ord(strengur[x]))
    
    skil = min(newList)
    return skil


def char(gildi):
    return chr(gildi)


lol = char(66)
print(str(lol))

#4
def add(length):
    if length == 0:
        newList.append(orgList[length])
    else:
        newList.append(orgList[length])
        add(length-1)


newList = []
orgList = [1,2,3]
add(len(orgList)-1)
print(newList)

#5
Það þarf einungis að athuga hvert stak einusinni

#6
Tíma flækjan eftir mínum skilning er 5n

#7
Hægt er að útfæra "hrópmerkt" fallið í Python með því að nota halaendurkvæmni

#8
return binary_search(l, value, mid + 1, high)

#9
Margliða af stigi 3 (t.d. n3)

#10
ef það er n í örðu er mikill munur á hæðsta og lægsta staki. Það á ekki við ef tímaflækjan er (n log n)
