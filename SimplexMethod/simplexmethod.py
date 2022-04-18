from prettytable import PrettyTable


class Task:
    '''
    F - purpose function as coefficients
    rawF - purpose function as string
    sofresK - coefficients of system of restrictions
    sofresX - X numbers in system of restrictions
    '''
    def __init__(self, F, rawF, sofresK, sofresX):
        self.F = F
        self.rawF = rawF
        self.sofresK = sofresK
        self.sofresX = sofresX

class SimplexMethod:
    def solve(self, task):
        step = 1
        
        task = self.prepare(task)
        task = self.compute_delta(task)
        
        print("Current step is", step)
        self.show(task)
        step += 1
        
        while self.check_optimality(task.delta):
            task = self.optimization(task)
            task = self.compute_delta(task)
            task = self.clear_double_nums(task)
            print("Current step is", step)
            self.show(task)
            step += 1
            input()
            
        print("The task is optimal")
        self.compute_purpose_function(task)
        
    def clear_double_nums(self, task):
        for i, row in enumerate(task.sofresK):
            for j, el in enumerate(row):
                task.sofresK[i][j] = round(task.sofresK[i][j], 2)
                
        return task
        
    def compute_purpose_function(self, task):
        F = task.rawF
        values = []
        for i, el in enumerate(task.basis):
            value = str(task.sofresK[i][-1])
            F = F.replace(el, value)
            if value in F:
                values.append(value)
        
        try:
            print("F(" + ', '.join(str(i) for i in values),
                ")", " = ", F, sep='', end=' = ') 
            print(eval(F))
        except Exception as e:
            print('ERROR')
            print(e)
        
    def check_optimality(self, delta):
        return 0 > min(delta)
        
    def optimization(self, task):
        key_element, key_column, key_row = self.compute_key_element(task)
       
        # swap basis and C
        task.basis[key_row] = task.Xb[key_column]
        task.C[key_row] = task.F[key_column]
        
        # divide key row
        for i, el in enumerate(task.sofresK[key_row]):
            try:
                task.sofresK[key_row][i] = round(el / key_element,2)
            except ZeroDivisionError:
                pass
        
        # substraction rows
        for i, row in enumerate(task.sofresK):
            if row != task.sofresK[key_row]:
                new_row = []
                for j, el in enumerate(row):
                    result = el - (task.sofresK[i][key_column] *
                        task.sofresK[key_row][j])
                    new_row.append(result)
                task.sofresK[i] = new_row
                
        return task
        
    def compute_key_element(self, task):
        # compute key column(index)
        min_delta = sorted(task.delta)[0]
        key_column = task.delta.index(min_delta)
        
        # compute key row(index)
        # cfs - coefficients
        result_dividing_cfs = []
        for i, row in enumerate(task.sofresK):
            try:
                result = round(row[-1] / row[key_column], 2)
                if 0 > result:
                    result_dividing_cfs.append(float('inf'))
                else:
                    result_dividing_cfs.append(result)
            except ZeroDivisionError:
                result_dividing_cfs.append(float('inf'))
            
        min_value = sorted(result_dividing_cfs)[0]
        key_row = result_dividing_cfs.index(min_value)
        
        # compute key element(index)
        key_element = task.sofresK[key_row][key_column]
        
        return key_element, key_column, key_row
        
    def compute_delta(self, task):
        for i, delta in enumerate(task.delta):
            result = 0
            for j, k in enumerate(task.C):
                result += task.C[j]*task.sofresK[j][i]
            result -= task.F[i]
            
            task.delta[i] = result
        
        return task
        
    def show(self, task):
        table = PrettyTable()
        table.add_row(["", "C"] + task.F)
        table.add_row(["C", "базис"] + task.Xb)
        
        for i, el in enumerate(task.basis):
            table.add_row([task.C[i], task.basis[i]] + task.sofresK[i])
            
        table.add_row(["", "Δ"] + task.delta)
            
        print(table, end='\n\n')
    
    def prepare(self, task):
        # extend purpose function
        X_count = len(task.sofresK)
        task.F.extend([0]*(X_count*2-2))
        
        # create delta
        task.delta = [0]*(X_count*2)
        
        # create x1, xn, b
        task.Xb = ['x' + str(i) for i in range(1, len(task.delta))] + ['b']
        
        # create basis and C(left)
        task.basis = [i for i in task.Xb[X_count-1:-1]]
        task.C = [0]*len(task.basis)
        
        # transform coefficients of system of restrictions
        for i, k in enumerate(task.sofresK):
            template = [0] * (X_count*2)
            template[-1] = k[-1] # b
            template[X_count+i-1] = 1 # new variable
            for j, x in enumerate(task.sofresX[i]):
                template[x-1] = k[j]
                
            task.sofresK[i] = template
                
        return task
                
                
        
        
        
        
        
        
        
        
        
        
        