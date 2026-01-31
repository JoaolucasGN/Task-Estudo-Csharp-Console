// Atividade 2 regra de negocios

// Random para negocios
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine(daysUntilExpiration);
daysUntilExpiration = 11;

// Regra 1. Exibir apenas uma mensagem. 

// Regra 2. A assinatura do usuário expira apenas em 10 dias ou menos.
if ((daysUntilExpiration <= 10) && (daysUntilExpiration >= 6))
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");

}
// Regra 3. Se a assinatura do usuário expirar em cinco dias ou menos, será exibida a mensagem:
else if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1))

{   discountPercentage = 10;
    Console.WriteLine($"our subscription expires in _ days.Renew now and save {discountPercentage}%!");
    
}
//Regra 4.  Se a assinatura do usuário expirar em um dia, serão exibidas as mensagens:

if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!. Renew now and save {discountPercentage}%!");
}

// Regra 5. Se a assinatura do usuário tiver expirado, será exibida a mensagem:

else if (daysUntilExpiration == 0)

{
    Console.WriteLine("Your subscription has expired.");
}
// Regra 6. Se a assinatura do usuário não expirar em dez dias ou menos, não será exibida nenhuma mensagem.
if (discountPercentage > 0)

{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

