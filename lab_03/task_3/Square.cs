﻿class Square : Shape
{
    public Square(IRenderer renderer) : base(renderer)
    {
    }

    public override void Draw()
    {
        renderer.RenderSquare();
    }
}