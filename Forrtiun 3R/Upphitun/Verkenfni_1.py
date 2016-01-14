#verkefni 1
sum = 0
for x in range(0, 1001):
	if x % 3 == 0:
		sum = sum + 3
	elif x % 5 == 0:
		sum = sum + 5
print sum

#verkefni 2
sum = 1
print str(sum + ", ")
last1 = 2
print str(last1 + ", ")
last2 = 3
print str(last2 + ", ")

while sum != 4000000:
	sum = last2 +last1
	print str(sum + ", ")
	last1 = last2
	last2 = sum

#verkefni 3
'''
lausn = 0
for x in range(1,600851475143):
	if x % 600851475143 == 0:
		lausn = x
print lausn
'''


