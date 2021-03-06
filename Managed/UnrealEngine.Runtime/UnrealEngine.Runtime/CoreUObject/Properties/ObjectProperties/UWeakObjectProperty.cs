﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnrealEngine.Runtime
{
    [UClass(Flags = (ClassFlags)0x10400080), UMetaPath("/Script/CoreUObject.WeakObjectProperty")]
    public class UWeakObjectProperty : UObjectPropertyBase
    {
        public override EPropertyType PropertyType
        {
            get { return EPropertyType.WeakObject; }
        }

        private PropertyAccessor<FWeakObjectPtr> accessor;
        public PropertyAccessor<FWeakObjectPtr> Accessor
        {
            get { return accessor == null ? accessor = new PropertyAccessor<FWeakObjectPtr>(this) : accessor; }
        }        
    }
}
