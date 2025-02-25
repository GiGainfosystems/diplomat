``decimal::ffi``
================

.. cpp:class:: ICU4XFixedDecimalFormat

    An ICU4X Fixed Decimal Format object, capable of formatting a :cpp:class:`ICU4XFixedDecimal` as a string.
    See the `Rust documentation <https://unicode-org.github.io/icu4x-docs/doc/icu/decimal/struct.FixedDecimalFormat.html>`__ for more information.

    .. cpp:function:: static ICU4XFixedDecimalFormatResult try_new(const ICU4XLocale& locale, const ICU4XDataProvider& provider, ICU4XFixedDecimalFormatOptions options)

        Creates a new :cpp:class:`ICU4XFixedDecimalFormat` from locale data.
        See the `Rust documentation <https://unicode-org.github.io/icu4x-docs/doc/icu/decimal/struct.FixedDecimalFormat.html#method.try_new>`__ for more information.

    .. cpp:function:: template<typename W> void format_write_to_writeable(const ICU4XFixedDecimal& value, W& write) const

        Formats a :cpp:class:`ICU4XFixedDecimal` to a string.
        See the `Rust documentation <https://unicode-org.github.io/icu4x-docs/doc/icu/decimal/struct.FixedDecimalFormat.html#method.format>`__ for more information.

    .. cpp:function:: std::string format_write(const ICU4XFixedDecimal& value) const

        Formats a :cpp:class:`ICU4XFixedDecimal` to a string.
        See the `Rust documentation <https://unicode-org.github.io/icu4x-docs/doc/icu/decimal/struct.FixedDecimalFormat.html#method.format>`__ for more information.

.. cpp:struct:: ICU4XFixedDecimalFormatOptions

    .. cpp:member:: ICU4XFixedDecimalGroupingStrategy grouping_strategy

    .. cpp:member:: ICU4XFixedDecimalSignDisplay sign_display

    .. cpp:function:: static ICU4XFixedDecimalFormatOptions default_()

.. cpp:struct:: ICU4XFixedDecimalFormatResult

    .. cpp:member:: std::optional<ICU4XFixedDecimalFormat> fdf

        The :cpp:class:`ICU4XFixedDecimalFormat`, exists if creation was successful.

    .. cpp:member:: bool success

        Whether creating the :cpp:class:`ICU4XFixedDecimalFormat` was successful.

.. cpp:enum-struct:: ICU4XFixedDecimalGroupingStrategy

    .. cpp:enumerator:: Auto

    .. cpp:enumerator:: Never

    .. cpp:enumerator:: Always

    .. cpp:enumerator:: Min2

.. cpp:enum-struct:: ICU4XFixedDecimalSignDisplay

    .. cpp:enumerator:: Auto

    .. cpp:enumerator:: Never

    .. cpp:enumerator:: Always

    .. cpp:enumerator:: ExceptZero

    .. cpp:enumerator:: Negative
