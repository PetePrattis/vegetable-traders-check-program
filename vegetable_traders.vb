Sub Main()
        Dim last_name As String
        Dim product_kind As Single
        Dim purchase _price As Integer
        Dim sell_price As Integer

        Dim profit As Integer
        Dim profit_perecentage As Integer

        Dim sum_traders_50 As Single
        Dim sum_sell_price_tomato As Integer
        Dim sum_sell_price_pepper As Integer
        Dim sum_sells_tomato As Single
        Dim sum_purchase s_pepper As Single
        Dim meani_sell_price_tomato As Integer
        Dim meani_purchase _price_pepper As Integer

        FileOpen(1, "C:\temp\Check.txt", OpenMode.Input)


        sum_traders_50 = 0

        sum_sell_price_tomato = 0
        sum_sell_price_pepper = 0
        sum_sells_tomato = 0
        sum_purchase s_pepper = 0

        Dim word1, word2, word3, word4 As String

        Do While Not EOF(1)
            Input(1, word1)
            Input(1, word2)
            Input(1, word3)
            Input(1, word4)
            MsgBox(word1 & word2 & word3 & word4)
            If word1 <> Nothing And word2 <> Nothing And word3 <> Nothing And word4 <> Nothing Then
                last_name = word1
                product_kind = Single.Parse(word2)
                purchase _price = Integer.Parse(word3)
                sell_price = Integer.Parse(word4)

                If sell_price > purchase _price Then 'can i make a profit if selling price > purchase ing price
                    profit = sell_price - purchase _price
                    profit_perecentage = (profit / purchase _price * 100)
                    If profit_perecentage > 30 Then
                        FileOpen(2, "C:\temp\Ιnfringements.txt", OpenMode.Append)
                        WriteLine(2)
                        WriteLine(2, last_name, product_kind, purchase _price, sell_price, profit_perecentage)
                        FileClose(2)
                        If profit_perecentage > 50 Then
                            sum_traders_50 = sum_traders_50 + 1
                        End If
                    End If
                End If
                If product_kind = 1 Then
                    sum_sell_price_tomato = sum_sell_price_tomato + sell_price
                    sum_sells_tomato = sum_sells_tomato + 1
                ElseIf product_kind = 3 Then
                    sum_sell_price_pepper = sum_sell_price_pepper + purchase _price
                    sum_purchase s_pepper = sum_purchase s_pepper + 1
                End If
            End If
        Loop

        FileClose(1)


        meani_sell_price_tomato = sum_sell_price_tomato / sum_sells_tomato
        meani_purchase _price_pepper = sum_sell_price_pepper / sum_purchase s_pepper

        MsgBox("The number of traders with a profit percentage greater than 50% is " & sum_traders_50)
        MsgBox("The average selling price per kilo of tomato is  " & meani_sell_price_tomato)
        MsgBox("The average purchase price per kilo of pepper is " & meani_purchase _price_pepper)

    End Sub