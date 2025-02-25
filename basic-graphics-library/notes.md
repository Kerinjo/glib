## Vector2
- Could add unary minus if needed.
- Equality. Normally for vectors that would be comparing direction and length,
    but for vector2 it's probably better to just compare coordinates since we can't change origin yet.

## Transformation Matrix

[x] - scaling
[] - shearing
[] - rotation
[] - reflection

- How do I implement that for v2, v3? Should there be 2x2, 3x3 and for Hv 4x4?
- One idea is to have a Transformation class, that accepts v2, v3, hv and does operations accordingly
- For now, scaling is a simple product, which is clean, but it's worth considering implementing it 
    as a matrix * vector operation, just for the sake of it.