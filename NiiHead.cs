using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NiiHead : MonoBehaviour
{
        public int sizeof_hdr;
        public char[] data_type = new char[10];
        public char[] db_name = new char[18];
        public int extents;
        public short session_error;
        public char regular;
        public char dim_info;
        public short[] dim = new short[8];

        public float intent_p1;
        public float intent_p2;
        public float intent_p3;

        public short intent_code;
        public short datatype;
        public short bitpix;
        public short slice_start;
        public float[] pixdim = new float[8];
        public float vox_offset;

        public float scl_slope;
        public float scl_inter;

        public short slice_end;
        public char slice_code;

        public char xyzt_units;
        public float cal_max;
        public float cal_min;
        public float slice_duration;
        public float toffset;
        public int glmax;
        public int glmin;

        public char[] descrip = new char[80];
        public char[] aux_file = new char[24];
        public short qform_code;
        public short sform_code;
        public float quatern_b;
        public float quatern_c;
        public float quatern_d;
        public float qoffset_x;
        public float qoffset_y;
        public float qoffset_z;

        public float[] srow_x = new float[4];
        public float[] srow_y = new float[4];
        public float[] srow_z = new float[4];

        public char[] intent_name = new char[16];
        public char[] magic = new char[4];


}
