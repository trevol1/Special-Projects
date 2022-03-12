import random

print('Welcome to Password Generator')

chars = 'abcdefghijklmnopqrstuvwxyzABCDEFGHJIKLMNOPQRSTUVWXYZ!"#$%&/()=.,;-_<>@*^¨´§?0123456789'

number = input('Amount of passwords to generate: ')
number = int(number)

password_length = input('Your password length: ')
password_length = int(password_length)

print ('\nHere are your passwords:')

for pwd in range(number):
    passwords = ''
    for c in range(password_length):
        passwords += random.choice(chars)
    print(passwords)