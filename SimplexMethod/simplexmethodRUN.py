from simplexmethod import SimplexMethod, Task

sm = SimplexMethod()
    
F = list(map(int, input('Введите коэффиценты F через пробел:').split()))

print()

print('Запишите целевую функцию в обычном виде')
print('Пример:',
    'F(x1,x2, x3) = x1+5x2-3x5',
    'Вводите: x1+5*x2-3*x5')
rawF = input('Вводите: ')

print()

print('Введите коэффиценты системы ограничений через пробел')
print('Ввели 1 ограничение -> [Enter]')
print('Конец - q')

print()

sofresK = []

while True:
    k = input('Введите коэффиценты:')
    if k == 'q':
        break
    sofresK.append(list(map(int, k.split())))
    
print()
    
print('Введите номера иксов системы ограничений через пробел')
print('x1 + x2 - 3x5 = 5 -> 1 2 5')
print('Конец - q')

print()

sofresX = []

while True:
    k = input('Введите номера иксов:')
    if k == 'q':
        break
    sofresX.append(list(map(int, k.split())))
    
print()
print(F, rawF, sofresK, sofresX, sep='\n')
    
task = Task(F, rawF, sofresK, sofresX)  

sm.solve(task)