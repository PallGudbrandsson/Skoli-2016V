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
lausn = 0
for x in range(1,600851475143):
	if x % 600851475143 == 0:
		lausn = x
print lausn

#verkefni 4
tala = 0
lengd = 0
talas = "strengur"
fyrri = ""
seinni = ""
lausn = ""
for x in xrange(99,1000):
	for a in xrange(99,1000):
		tala = a*x
		talas = str(tala)
		if talas == talas[::-1]:
			lausn = talas
print talas
			



for x in xrange(1,1000000):
	y = 1+1
print x
		