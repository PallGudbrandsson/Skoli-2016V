talan = 600851475143 
deiling = 2
prime = True

while talan != 1:
	if talan % deiling == 0:
		for x in xrange(1,deiling):
			if deiling % x == 0:
				if x == 1:
					pass
				else:
					prime = False
		if prime == True:
			talan = talan / deiling
		else:
			prime = True
	else:
		deiling = deiling + 1
print (deiling)