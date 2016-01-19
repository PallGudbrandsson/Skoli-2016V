talan = 0
Strengur = ""
output = ""

for x in xrange(100,1000):
	for a in xrange(100,1000):
		talan = x * a
		Strengur = str(talan)
		if Strengur == Strengur[::-1]:
			output = Strengur
print (output)