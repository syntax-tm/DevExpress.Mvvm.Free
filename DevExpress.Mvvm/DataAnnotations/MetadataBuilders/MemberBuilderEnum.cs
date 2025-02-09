using DevExpress.Mvvm.Native;

namespace DevExpress.Mvvm.DataAnnotations {
    public class EnumMemberMetadataBuilderGeneric<T, TBuilder> :
        MemberMetadataBuilderBase<T, TBuilder, EnumMetadataBuilder<T>>
        where T : struct 
        where TBuilder : EnumMemberMetadataBuilderGeneric<T, TBuilder> {
        internal EnumMemberMetadataBuilderGeneric(MemberMetadataStorage storage, EnumMetadataBuilder<T> parent)
            : base(storage, parent) {
        }
        public EnumMetadataBuilder<T> EndMember() { return parent; }

        public TBuilder DisplayName(string name) { return DisplayNameCore(name); }
        public TBuilder Description(string description) { return DescriptionCore(description); }
        public TBuilder NotAutoGenerated() { return NotAutoGeneratedCore(); }
        public TBuilder ImageUri(string imageUri) { return ImageUriCore(imageUri); }
    }

    public class EnumMemberMetadataBuilder<T> : 
        EnumMemberMetadataBuilderGeneric<T, EnumMemberMetadataBuilder<T>>
        where T : struct {

        internal EnumMemberMetadataBuilder(MemberMetadataStorage storage, EnumMetadataBuilder<T> parent)
            : base(storage, parent) {
        }
    }
}
