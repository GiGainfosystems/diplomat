#ifndef diplomat_result_box_ResultOpaque_ErrorEnum_H
#define diplomat_result_box_ResultOpaque_ErrorEnum_H
#include <stdio.h>
#include <stdint.h>
#include <stddef.h>
#include <stdbool.h>
#include "diplomat_runtime.h"

#ifdef __cplusplus
extern "C" {
#endif
typedef struct ResultOpaque ResultOpaque;
#include "ErrorEnum.h"
typedef struct diplomat_result_box_ResultOpaque_ErrorEnum {
    union {
        ResultOpaque* ok;
        ErrorEnum err;
    };
    bool is_ok;
} diplomat_result_box_ResultOpaque_ErrorEnum;
#ifdef __cplusplus
}
#endif
#endif
