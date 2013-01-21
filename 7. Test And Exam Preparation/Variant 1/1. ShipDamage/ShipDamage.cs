using System;

class ShipDamage
{
    static void Main()
    {
        int sx1, sx2, sy1, sy2, h, cx1, cy1, cx2, cy2, cx3, cy3;
        sx1 = int.Parse(Console.ReadLine());
        sy1 = int.Parse(Console.ReadLine());
        sx2 = int.Parse(Console.ReadLine());
        sy2 = int.Parse(Console.ReadLine());
        h = int.Parse(Console.ReadLine());
        cx1 = int.Parse(Console.ReadLine());
        cy1 = int.Parse(Console.ReadLine());
        cx2 = int.Parse(Console.ReadLine());
        cy2 = int.Parse(Console.ReadLine());
        cx3 = int.Parse(Console.ReadLine());
        cy3 = int.Parse(Console.ReadLine());

        cy1 += (h - cy1) * 2;
        cy2 += (h - cy2) * 2;
        cy3 += (h - cy3) * 2;

        int demage = 0;

        int topLeftX, topLeftY, topRightX, topRightY, bottomLeftX, bottomLeftY, bottomRightX, bottomRightY;
        if(sx1 > sx2)
        {
            if(sy1 > sy2)
            {
                topRightX = sx1;
                topRightY = sy1;
                bottomLeftX = sx2;
                bottomLeftY = sy2;
                topLeftX = sx2;
                topLeftY = sy1;
                bottomRightX = sx1;
                bottomRightY = sy2;
            }
            else
            {
                bottomRightX = sx1;
                bottomRightY = sy1;
                topLeftX = sx2;
                topLeftY = sy2;
                bottomLeftX = sx2;
                bottomLeftY = sy1;
                topRightX = sx1;
                topRightY = sy2;
            }
        }
        else
        {
            if (sy1 > sy2)
            {
                topLeftX = sx1;
                topLeftY = sy1;
                bottomRightX = sx2;
                bottomRightY = sy2;
                topRightX = sx2;
                topRightY = sy1;
                bottomLeftX = sx1;
                bottomLeftY = sy2;
            }
            else
            {
                bottomLeftX = sx1;
                bottomLeftY = sy1;
                topRightX = sx2;
                topRightY = sy2;
                bottomRightX = sx2;
                bottomRightY = sy1;
                topLeftX = sx1;
                topLeftY = sy2;
            }
        }

        if ((cx1 == bottomRightX && cy1 == bottomRightY) ||
            (cx1 == bottomLeftX && cy1 == bottomLeftY) ||
            (cx1 == topLeftX && cy1 == topLeftY) ||
            (cx1 == topRightX && cy1 == topRightY))
        {
            demage += 25;
        }

        if ((cx2 == bottomRightX && cy2 == bottomRightY) ||
            (cx2 == bottomLeftX && cy2 == bottomLeftY) ||
            (cx2 == topLeftX && cy2 == topLeftY) ||
            (cx2 == topRightX && cy2 == topRightY))
        {
            demage += 25;
        }

        if ((cx3 == bottomRightX && cy3 == bottomRightY) ||
            (cx3 == bottomLeftX && cy3 == bottomLeftY) ||
            (cx3 == topLeftX && cy3 == topLeftY) ||
            (cx3 == topRightX && cy3 == topRightY))
        {
            demage += 25;
        }

        if ((cx1 > topLeftX && cx1 < topRightX && cy1 == topLeftY) ||
            (cx1 > bottomLeftX && cx1 < bottomRightX && cy1 == bottomLeftY) ||
            (cy1 > bottomLeftY && cy1 < topLeftY && cx1 == bottomLeftX) ||
            (cy1 > bottomRightY && cy1 < topRightY && cx1 == topRightX))
        {
            demage += 50;
        }

        if ((cx2 > topLeftX && cx2 < topRightX && cy2 == topLeftY) ||
            (cx2 > bottomLeftX && cx2 < bottomRightX && cy2 == bottomLeftY) ||
            (cy2 > bottomLeftY && cy2 < topLeftY && cx2 == bottomLeftX) ||
            (cy2 > bottomRightY && cy2 < topRightY && cx2 == topRightX))
        {
            demage += 50;
        }

        if ((cx3 > topLeftX && cx3 < topRightX && cy3 == topLeftY) ||
            (cx3 > bottomLeftX && cx3 < bottomRightX && cy3 == bottomLeftY) ||
            (cy3 > bottomLeftY && cy3 < topLeftY && cx3 == bottomLeftX) ||
            (cy3 > bottomRightY && cy3 < topRightY && cx3 == topRightX))
        {
            demage += 50;
        }

        if (cx1 > topLeftX && cx1 < topRightX && cy1 > bottomLeftY && cy1 < topLeftY)
        {
            demage += 100;
        }

        if (cx2 > topLeftX && cx2 < topRightX && cy2 > bottomLeftY && cy2 < topLeftY)
        {
            demage += 100;
        }

        if (cx3 > topLeftX && cx3 < topRightX && cy3 > bottomLeftY && cy3 < topLeftY)
        {
            demage += 100;
        }

        Console.WriteLine(demage + "%");
    }
}
