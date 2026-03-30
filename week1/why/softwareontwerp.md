# why software design (3)

1) writing good software is more then syntax alone.
2) developing better/robuster software
3) better an more efficient software

## requirements (2)

### primary 

What is the end `goal` => create `good` software with `minimum` effort.

#### what is good software (4)

1) **does what it needs to**
2) `reliable` => no bugs
3) user/developer `friendly` => good `GUI` + `docs`
4) flexible/`maintainable` => `good software` is an `ongoing process`, **never finished**.

#### what is a good development process (2)

1) efficient
2) `no irritation` between client and developer
   
### derived 

`how` do we `reach` the `primary requirements`?

#### Modules

1) separation of concerns
2) software must be separated in modules
    - code is easier to find
    - no spaghetti

> [!NOTE]
> `each task` must have a `corresponding module/function`.
>
> 1) OOP => classes/packages 
> 2) functional programming => each task has a function

#### Understandable and tested

1) understandable => follow the style guide
2) tested => all parts of the code base need to be tested
   - test `small parts` first, then test `modules`.
   - test `edge cases` to

#### documentation (3)

1) important for:
    - maintainability
    - reusability
    - flexibility
2) try and make code self documenting => easy to understand
3) also add following docs:
   1) class docs: function, interdependencies
   2) method docs: what does it do?

#### robustness (3)

1) `protect` module against `malicious input`
2) NO hidden dependencies
    - example: no hidden dependency on a obscure env variable (github.SECRET_TOKEN)
3) Avoid input assumptions => test the input!
    - example: table size
    - example: max records in a DB

#### reusability (3)

1) ideas => design patterns
2) code => libraries frameworks
3) code in same project.

> [!NOTE]
> with `reusability` comes allot of `advantages`:
>
> 1) labor saving
> 2) better quality software