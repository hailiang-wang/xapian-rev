/* Warning: This file is generated by ./generate-exceptions - do not modify directly! */
/* Copyright (C) 2003,2004,2006,2007,2008,2009,2011,2015 Olly Betts
 * Copyright (C) 2007 Richard Boulton
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as
 * published by the Free Software Foundation; either version 2 of the
 * License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301 USA
 */

/* Note that this file isn't an external header - it's located in
 * include/xapian in the source tree because it's generated so this
 * is the simplest way to make inclusion work in a VPATH build.
 */

// DOXYGEN gets confused by this header-with-code.
#ifndef DOXYGEN
case '\000': throw Xapian::AssertionError(msg, context, error_string);
case '\001': throw Xapian::InvalidArgumentError(msg, context, error_string);
case '\002': throw Xapian::InvalidOperationError(msg, context, error_string);
case '\003': throw Xapian::UnimplementedError(msg, context, error_string);
case '\004': throw Xapian::DatabaseError(msg, context, error_string);
case '\005': throw Xapian::DatabaseCorruptError(msg, context, error_string);
case '\006': throw Xapian::DatabaseCreateError(msg, context, error_string);
case '\007': throw Xapian::DatabaseLockError(msg, context, error_string);
case '\010': throw Xapian::DatabaseModifiedError(msg, context, error_string);
case '\011': throw Xapian::DatabaseOpeningError(msg, context, error_string);
case '\012': throw Xapian::DatabaseVersionError(msg, context, error_string);
case '\013': throw Xapian::DocNotFoundError(msg, context, error_string);
case '\014': throw Xapian::FeatureUnavailableError(msg, context, error_string);
case '\015': throw Xapian::InternalError(msg, context, error_string);
case '\016': throw Xapian::NetworkError(msg, context, error_string);
case '\017': throw Xapian::NetworkTimeoutError(msg, context, error_string);
case '\020': throw Xapian::QueryParserError(msg, context, error_string);
case '\021': throw Xapian::SerialisationError(msg, context, error_string);
case '\022': throw Xapian::RangeError(msg, context, error_string);
case '\023': throw Xapian::WildcardError(msg, context, error_string);
case '\024': throw Xapian::DatabaseNotFoundError(msg, context, error_string);
case '\025': throw Xapian::DatabaseClosedError(msg, context, error_string);
#endif /* DOXYGEN */
