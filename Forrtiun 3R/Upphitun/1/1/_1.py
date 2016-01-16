sum = 0
for x in range(0, 1001):
	if x % 3 == 0:
		sum = sum + 3
	elif x % 5 == 0:
		sum = sum + 5
print sum
