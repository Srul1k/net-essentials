namespace FluentValidatorLibrary
{
    public interface IValidator<T>
    {
        ValidationResult<T> Validate(T entity);
    }
}
