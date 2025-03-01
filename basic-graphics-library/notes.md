## Vectors

- Could add unary minus if needed.
- Equality. Normally for vectors that would be comparing direction and length,
    but for vector2 it's probably better to just compare coordinates since we can't change origin yet.
- Quality of life: Parse vectors from string

## Transform Class

- [ ] scaling 
    - [x] done with scalar
    - [ ] scaling with matrix
- [ ] shearing
- [ ] rotation
- [ ] reflection
 
 
- How do I implement that for v2, v3? Should there be 2x2, 3x3 and for Hv 4x4?
- One idea is to have a Transformation class, that accepts v2, v3, hv and does operations accordingly
- For now, scaling is a simple product, which is clean, but it's worth considering implementing it 
    as a matrix * vector operation, just for the sake of it.

Let's go with matrix classes for transformation purposes, they might turn out to be useful later anyway.
I want 3 distinct matrix classes: 2x2, 3x3 and 4x4 (when I implement the HVector eventually)

## Matrices

- [ ] For parsing from string, try to use:
```
    var matches = Regex.Matches(text, @"-?\d+");
    if (matches.Count != 4) return false;
```

## Performance

- [ ] If I have too much time, I could possibly create those constructs with structs instead of classes and see 
    how that affects performance, but I think it's only necessary once I arrive at performance issues. 

