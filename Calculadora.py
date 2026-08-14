def sumar(num1, num2):
    total = num1 + num2
    return total

def restar(num1, num2):
    total = num1 - num2
    return total

def multiplicar(num1, num2):
    total = num1 * num2
    return total

def dividir(num1, num2):
    if (num2==0):
        return "neverlan"

        total = num1 / num2
        return num1 / num2

def main():
    num1 = 12
    num2 = 45

    print(sumar(num1, num2))
    print(restar(num1, num2))
    print(multiplicar(num1, num2))
    print(dividir(num1, num2))

if __name__ == "__main__":
    main()
