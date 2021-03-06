/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System;
using System.Collections.Generic;
using System.Text;
using Thrift.Protocol;

namespace Hive
{
#if !SILVERLIGHT

#endif

    public partial class ShowLocksResponse : TBase
    {
        private List<ShowLocksResponseElement> _locks;

        public List<ShowLocksResponseElement> Locks
        {
            get
            {
                return _locks;
            }
            set
            {
                __isset.locks = true;
                this._locks = value;
            }
        }

        public Isset __isset;
#if !SILVERLIGHT

#endif

        public struct Isset
        {
            public bool locks;
        }

        public ShowLocksResponse()
        {
        }

        public void Read(TProtocol iprot)
        {
            TField field;
            iprot.ReadStructBegin();
            while (true)
            {
                field = iprot.ReadFieldBegin();
                if (field.Type == TType.Stop)
                {
                    break;
                }
                switch (field.ID)
                {
                    case 1:
                        if (field.Type == TType.List)
                        {
                            {
                                Locks = new List<ShowLocksResponseElement>();
                                TList _list213 = iprot.ReadListBegin();
                                for (int _i214 = 0; _i214 < _list213.Count; ++_i214)
                                {
                                    ShowLocksResponseElement _elem215 = new ShowLocksResponseElement();
                                    _elem215 = new ShowLocksResponseElement();
                                    _elem215.Read(iprot);
                                    Locks.Add(_elem215);
                                }
                                iprot.ReadListEnd();
                            }
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;

                    default:
                        TProtocolUtil.Skip(iprot, field.Type);
                        break;
                }
                iprot.ReadFieldEnd();
            }
            iprot.ReadStructEnd();
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("ShowLocksResponse");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            if (Locks != null && __isset.locks)
            {
                field.Name = "locks";
                field.Type = TType.List;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                {
                    oprot.WriteListBegin(new TList(TType.Struct, Locks.Count));
                    foreach (ShowLocksResponseElement _iter216 in Locks)
                    {
                        _iter216.Write(oprot);
                    }
                    oprot.WriteListEnd();
                }
                oprot.WriteFieldEnd();
            }
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("ShowLocksResponse(");
            sb.Append("Locks: ");
            sb.Append(Locks);
            sb.Append(")");
            return sb.ToString();
        }
    }
}